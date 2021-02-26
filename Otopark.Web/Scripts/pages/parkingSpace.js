$(function () {
    id = 0;
    carParkSpaceId = 0;
    loadData();
    pay = {};
    newId = 0;

    $("#btnNew").click(function () {
        $("#parkSpaceModal").modal("show");
        $("#parkSpaceModalTitle").text("Yeni Park Yeri");
        newId = 0;
        $("#txtParkingSpace").val('');
    });

    $("#btnSave").click(function () {
        var data = {
            Id: newId,
            ParkingSpaces: $("#txtParkingSpace").val()
        };

        $.post("/ParkingSpaces/CreateOrUpdate", data, (res) => {
            $("#parkSpaceModal").modal("hide");
            dataSource.read();
        });
    });
    function edit(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        $("#parkSpaceModal").modal("show");
        $("#parkSpaceModalTitle").text("Park Yeri Düzenle");
        newId = dataItem.Id;
        $("#txtParkingSpace").val(dataItem.ParkingSpaces);
    }

    function remove(e) {
        e.preventDefault();
        if (confirm("Silmek istediğinize emin misiniz?")) {
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            $.post("/ParkingSpaces/Delete/" + dataItem.Id, (res) => {
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
                url: "/ParkingSpaces/List",
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
            { field: "ParkingSpaces", title: "Park Yerleri" }
        ]
    });

    function loadData() {
        $("#errorMessage").hide();

        $.get("/ParkingSpaces/List", (res) => {
            $("#carParkingSpaces").html("");
            res.forEach((e) => {
                var html = "<div class='col-md-3 mb-5'>";
                if (e.Status) {
                    html = html + "<div class='card bg-danger'><div class='card-header'><div class='text-white'><div><i class='k-icon k-i-map-marker'></i>" + e.ParkingSpaces + "</div></div></div><div class='card-body'><div class='d-grid gap-2 d-md-flex justify-content-md-end'><button data-id='" + e.Id + "' class='btn btn-light btn-sm pay'>Ödeme Yap</button></div></div></div>";
                }
                else {
                    html = html + "<div class='card bg-success'><div class='card-header'><div class='text-white'><div><i class='k-icon k-i-map-marker'></i>" + e.ParkingSpaces + "</div></div></div><div class='card-body'><div class='d-grid gap-2 d-md-flex justify-content-md-end'><button data-id='" + e.Id + "' class='btn btn-light btn-sm add'>Araç Ekle</button></div></div></div>";
                }
                html = html + "</div>";
                $("#carParkingSpaces").append(html);
            });
        });

    }

    $(document).on('click', ".add", function () {
        id = $(this).attr('data-id');
        $("#parkModal").modal("show");

        var customerDataSource = new kendo.data.DataSource({
            transport: {
                read: {
                    url: "/Customer/GetEmptyPark",
                    dataType: "json"
                }
            },
            pageSize: 5
        });

        var customer = $("#customerGrid").data("kendoGrid");
        customer.setDataSource(customerDataSource);
    });

    $(document).on('click', ".pay", function () {
        carParkSpaceId = $(this).attr('data-id');
        $("#payModal").modal("show");
        pay = {};
        $.get("ParkingSpaces/PayDetails/" + carParkSpaceId, (res) => {
            pay = res;
            $("#txtPlaque").val(res.Plaque);
            $("#txtNameSurname").val(res.NameSurname);
            $("#txtTelephone").val(res.Telephone);
            $("#txtParkingSpaces").val(res.ParkingSpaces);
            $("#txtBrandName").val(res.BrandName);
            $("#txtSerieName").val(res.SerieName);
            $("#txtEntryDate").val(res.EntryDate);
            $("#txtExitDate").val(res.ExitDate);
            $("#txtHour").val(res.Time);
            $("#txtAmount").val(res.Amount);
        });
    });

    $("#btnPay").click(function () {
        $.post("./Sell/Pay", pay, (res) => {
            $("#payModal").modal("hide");
            loadData();
        });
    });

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/ParkingSpaces/List",
                dataType: "json"
            }
        },
        pageSize: 5
    });

    function select(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        var data = {
            CarParkSpaceId: id,
            CustomerId: dataItem.Id
        };

        $.post("/ParkingSpaces/ChangeStatus", data, (res) => {
            $("#parkModal").modal("hide");
            loadData();
        });
    }


    $("#customerGrid").kendoGrid({
        scrollable: true,
        sortable: true,
        filterable: {
            mode: "row"
        },
        pageable: {
            alwaysVisible: true,
            pageSizes: [5, 10, 20, 100]
        },
        columns: [
            { field: "NameSurname", title: "Adı Soyadı" },
            { field: "Plaque", title: "Plaka" },
            { field: "BrandName", title: "Markası" },
            { field: "SerieName", title: "Serisi" },
            {
                command: [{ name: "select", text: "Seç", click: select, className: "bg-warning text-white" }], title: " ", width: "100px"
            }
        ]
    });
});