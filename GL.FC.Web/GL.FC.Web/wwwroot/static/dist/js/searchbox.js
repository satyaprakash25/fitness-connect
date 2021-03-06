var data = [
    {
        "search_type": "user",
        "name": "sagar.sehar",
        "icon": "fa fa-user"
    },
    {
        "search_type": "transformation",
        "name": "We have gone through ....",
        "icon": "fa fa-feed"
    },
    {
        "search_type": "blog",
        "name": "Have you tried...",
        "icon": "fa fa-child"
    },
    {
        "search_type": "blog",
        "name": "Have you tried...",
        "icon": "fa fa-child"
    }
];

$('#txt-search').keyup(function () {
    var searchField = $(this).val();
    if (searchField === '') {
        $('#filter-records').html('');
        return;
    }
    if ($(this).val().length > 2) {
        var regex = new RegExp(searchField, "i");
        var output = '<div class="row" style="position:absolute;z-index:1;width:100%;margin:auto;">';
        var count = 1;
        $.each(data, function (key, val) {
            if ((val.name.search(regex) != -1) || (val.search_type.search(regex) != -1)) {
                output += '<p class="well" style="margin:0px;border:1px solid" ><a href="#" style="color: #3c8dbc"><i class="' + val.icon + '"></i> <b>' + val.search_type + '</b> ' + val.name + '</a></p> ';

                count++;

            }
        });
        output += '</div>';
        $('#filter-records').html(output);
    }

});
