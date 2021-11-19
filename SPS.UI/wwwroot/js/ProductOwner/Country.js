//#region Add New Category
$('body').on('click', "#btnSubmit", function () {
    var countryName = $("#txtCountryName").val();
    var status = $("#ddlRole").val();
   
    var Response = function (result) {
        if (result != "" || result.length > 0) {
            if (result === 1) {
                CommonUtility.SucessMessagePopUp("Country saved successfully.");
                Clear();
            }
            if (result === -1)
                CommonUtility.SucessMessagePopUp("Country already exists, could you try another name.");
            if (result === 2)
                CommonUtility.SucessMessagePopUp("Country not saved try after some time.");
        }
    }

    var Clear = function () {
        $("#txtCountryName").val('');
        $("#ddlRole").val('0');
    }
    var countryData = {
        CountryName: countryName,
        Status: status,
    };
    var url = '/ProductOwner/MasterData/Country/';
    CommonUtility.RequestAjax('POST', url, countryData, Response, null, null, null);
});

