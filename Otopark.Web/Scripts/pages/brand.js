$(function () {
    var id = 0;

    $("#btnNew").click(function () {
        $("#brandModal").modal("show");
        $("#brandModalTitle").text("Yeni Marka");
        id = 0;
        $("#txtBrandName").val('');
    });

    $("#btnSave").click(function () {
        var data = {
            Id: id,
            BrandName: $("#txtBrandName").val()
        };

        $.post("/Brand/CreateOrUpdate", data, (res) => {
            $("#brandModal").modal("hide");
            dataSource.read();
        });
    });

    function edit(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        $("#brandModal").modal("show");
        $("#brandModalTitle").text("Marka Düzenle");
        id = dataItem.Id;
        $("#txtBrandName").val(dataItem.BrandName);
    }

    function remove(e) {
        e.preventDefault();
        if (confirm("Silmek istediğinize emin misiniz?")) {
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            $.post("/Brand/Delete/" + dataItem.Id, (res) => {
                if (res.IsSuccess) {
                    dataSource.read();
                }
                else {
                    kendo.alert(res.Message);
                }
            });
        }
    }

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/Brand/List",
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
            { field: "BrandName", title: "Marka Adı" }
        ]
    });
});