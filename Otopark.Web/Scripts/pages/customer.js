

$(function () {
    var id = 0;

    $("#btnNew").click(function () {
        $("#customerModal").modal("show");
        $("#customerModalTitle").text("Yeni Müşteri");
        id = 0;
        $("#txtNameSurname").val('');
        $("#txtPlaque").val('');
        $("#txtTelephone").val('');
        $("#txtColor").val('');
        $("#txtComment").val('');
        $("#txtYear").val('');
        $("#cmbBrandName").data("kendoDropDownList").value('');
        $("#cmbSerieName").data("kendoDropDownList").value('');
    });


    $("#btnSave").click(function () {
        var data = {
            Id: id,
            NameSurname: $("#txtNameSurname").val(),
            Plaque: $("#txtPlaque").val(),
            Telephone: $("#txtTelephone").val(),
            Color: $("#txtColor").val(),
            Comment: $("#txtComment").val(),
            Year: $("#txtYear").val(),
            BrandId: parseInt($("#cmbBrandName").val()),
            SerieId: parseInt($("#cmbSerieName").val())
        };
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
        $("#txtNameSurname").val(dataItem.NameSurname);
        $("#txtPlaque").val(dataItem.Plaque);
        $("#txtTelephone").val(dataItem.Telephone);
        $("#txtColor").val(dataItem.Color);
        $("#txtComment").val(dataItem.Comment);
        $("#txtYear").val(dataItem.Year);
        $("#cmbBrandName").data("kendoDropDownList").value(dataItem.BrandId);
        onBrandChange(dataItem.SerieId);
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
        optionLabel: {
            BrandName: "Marka Seçiniz",
            Id: ""
        },
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

    $("#cmbBrandName").data("kendoDropDownList");

    function onBrandChange(e) {
        var brandId = $("#cmbBrandName").val();
        var serieDataSource = new kendo.data.DataSource({
            transport: {
                read: {
                    url: "/Serie/GetByBrandId/" + brandId,
                    dataType: "json"
                }
            }
        });
        var cmbSerieName = $("#cmbSerieName").data("kendoDropDownList");
        cmbSerieName.setDataSource(serieDataSource);
        if (e) {
            cmbSerieName.value(e);
        }
    }

    $("#cmbSerieName").kendoDropDownList({
        dataTextField: "SerieName",
        dataValueField: "Id",
        optionLabel: {
            SerieName: "Seri Seçiniz",
            Id: ""
        }
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