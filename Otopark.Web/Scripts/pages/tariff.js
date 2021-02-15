

$(function () {
    var id = 0;

    $("#btnNew").click(function () {
        $("#tariffModal").modal("show");
        $("#tariffModalTitle").text("Yeni Tarife");
        id = 0;
        $("#txtStartHour").val('');
        $("#txtEndHour").val('');
        $("#txtAmount").val('');

    });

    $("#txtStartHour").kendoNumericTextBox({
        format: "#",
        min: 0,
        step: 1
    });

    $("#txtEndHour").kendoNumericTextBox({
        format: "#",
        min: 0,
        step: 1
    });

    $("#txtAmount").kendoNumericTextBox({
        format: "#.00",
        min: 0,
        step: 0.01,
        culture: "tr-TR"
    });

    $("#btnSave").click(function () {
        var data = {
            Id: id,
            StartHour: parseInt($("#txtStartHour").val()),
            EndHour: parseInt($("#txtEndHour").val()),
            Amount: parseFloat($("#txtAmount").val())
        };
        console.log(data);
        $.post("/Tariff/CreateOrUpdate", data, (res) => {
            $("#tariffModal").modal("hide");
            dataSource.read();
        });
    });

    function edit(e) {
        e.preventDefault();
        var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
        $("#tariffModal").modal("show");
        $("#tariffModalTitle").text("Tarife Düzenle");
        id = dataItem.Id;
        $("#txtAmount").data("kendoNumericTextBox").value(dataItem.Amount);
        $("#txtStartHour").data("kendoNumericTextBox").value(dataItem.StartHour);
        $("#txtEndHour").data("kendoNumericTextBox").value(dataItem.EndHour);
    }

    function remove(e) {
        e.preventDefault();
        if (confirm("Silmek istediğinize emin misiniz?")) {
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            $.post("/Tariff/Delete/" + dataItem.Id, (res) => {
                dataSource.read();
            });
        }
    }

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: "/Tariff/List",
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
            { field: "StartHour", title: "Başlangıç Saati" },
            { field: "EndHour", title: "Bitiş Saati" },
            { field: "Amount", title: "Ücreti" }
        ]
    });
});