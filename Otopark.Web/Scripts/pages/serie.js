$(function () {
    id = 0;
    $("#btnNew").click(function () {
        $("#serieModal").modal("show");
        $("#serieModalTitle").text("Yeni Seri");
        id = 0;
        $("#cmbBrandName").val('');
        $("#txtSerieName").val('');
    });

    $("#cmbBrandName").kendoDropDownList({
        dataTextField: "BrandName",
        dataValueField: "Id",
        dataSource: {
            transport: {
                read: {
                    url: "/Brand/List",
                    dataType: "json"
                }
            }
        }
    });


    $("#btnSave").click(function () {
        var data = {
            Id: id,
            BrandId: $("#cmbBrandName").val(),
            SerieName: $("#txtSerieName").val()
        };

        $.post("/Serie/CreateOrUpdate", data, (res) => {
            $("#serieModal").modal("hide");
            dataSource.read();
        });
    });

    function edit(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        $("#serieModal").modal("show");
        $("#serieModalTitle").text("Seri Düzenle");
        id = dataItem.Id;
        $("#txtSerieName").val(dataItem.SerieName);
    }

    function remove(e) {
        e.preventDefault();
        if (confirm("Silmek istediğinize emin misiniz?")) {
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            $.post("/Serie/Delete/" + dataItem.Id, (res) => {
                dataSource.read();
            });
        }

    }

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/Serie/List",
                dataType: "json"
            }
        },
        pageSize: 5
    });

    $("#grid").kendoGrid({
        dataSource: dataSource,
        scrollable: true,
        sortable: true,
        filterable: true,
        pageable: {
            alwaysVisible: true,
            pageSizes: [5, 10, 20, 100]
        },
        columns: [
            {
                command: [{ name: "edit", text: "", click: edit, className: "bg-warning text-white" },
                { name: "remove", iconClass: "k-icon k-i-trash", text: "", click: remove, className: "bg-danger text-white" }], title: " ", width: "180px"
            },
            { field: "BrandName", title: "Marka Adı" },
            { field: "SerieName", title: "Seri Adı" }
        ]
    });
});