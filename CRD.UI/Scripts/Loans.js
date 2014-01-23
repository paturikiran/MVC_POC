function GetLoans() {
    var url = "loan/GetLoansByLoanId/";
    var loanId = $('#txtLoanNumber').val();
    $.ajax({
        url: url + loanId,
        contentType: 'application/html;charset=utf-8',
        type: 'GET',
        dataType: 'html'
    }).success(function (result) {
        $('#loansList').html(result);
    })
        .error(function (xhr, status) {
            alert(status);
        });
}

function ShowLoanDetails(id) {
    var url = "loan/GetLoanDetails/";
    $.ajax({
        url: url + id,
        contentType: 'application/html;charset=utf-8',
        type: 'GET',
        dataType: 'html'
    }).success(function (result) {
        $('#loanData').html(result);
    })
           .error(function (xhr, status) {
               alert(status);
           });
}