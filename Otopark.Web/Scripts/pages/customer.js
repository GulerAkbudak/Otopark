

$(function () {
    var id = 0;
    var serieDataSource;

    $("#btnNew").click(function () {
        $("#customerModal").modal("show");
        $("#customerModalTitle").text("Yeni Müşteri");
        id = 0;
        $("#txtStartHour").val('');
        $("#txtEndHour").val('');
        $("#txtAmount").val('');

    });


    $("#btnSave").click(function () {
        var data = {
            Id: id,
            StartHour: parseInt($("#txtStartHour").val()),
            EndHour: parseInt($("#txtEndHour").val()),
            Amount: parseFloat($("#txtAmount").val())
        };
        console.log(data);
        $.post("/Customer/CreateOrUpdate", data, (res) => {
            $("#customerModal").modal("hide");
            dataSource.read();
        });
    });

    function edit(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        $("#customerModal").modal("show");
        $("#customerModalTitle").text("Müşteri Düzenle");
        id = dataItem.Id;
    }

    function remove(e) {
        e.preventDefault();
        if (confirm("Silmek istediğinize emin misiniz?")) {
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            $.post("/Customer/Delete/" + dataItem.Id, (res) => {
                dataSource.read();
            });
        }
    }

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/Customer/List",
                dataType: "json"
            }
        },
        pageSize: 5
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
        },
        change: onBrandChange
    });

    var cmbBrandName = $("#cmbBrandName").data("kendoDropDownList");

    function onBrandChange() {
        var brandId = $("#cmbBrandName").val();
        var cmbSerieName = $("#cmbSerieName").data("kendoDropDownList");

        serieDataSource = new kendo.data.DataSource({
            transport: {
                transport: {
                    read: {
                        url: "/Serie/GetByBrandId/" + brandId,
                        dataType: "json"
                    }
                }
            }
        });
    }

    $("#cmbSerieName").kendoDropDownList({
        dataTextField: "SerieName",
        dataValueField: "Id",
        dataSource: serieDataSource
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
            { field: "NameSurname", title: "Adı Soyadı" },
            { field: "Plaque", title: "Plaka" },
            { field: "BrandName", title: "Markası" },
            { field: "SerieName", title: "Serisi" },
            { field: "Color", title: "Renk" },
            { field: "Telephone", title: "Telefon" },
            { field: "Year", title: "Yıl" },
            { field: "ParkingSpaces", title: "Park Yeri" },
            { field: "EntryDate", title: "Giriş Saati" }
        ]
    });
});