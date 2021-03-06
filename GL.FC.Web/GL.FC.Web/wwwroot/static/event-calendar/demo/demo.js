var defaultTheme = getRandom(4);

var today = new Date();

var events = [
    {
        id: 'bHay68s', // Event's ID (required)
        name: "Personal Traning", // Event name (required)
        date: "March/3/2021", // Date range        
        description: "PT for Yoga", // Event description (optional)
        type: "event", // Event type (required)
        color: "#63d867", // Event custom color (optional)
        icon:"chalkboard-teacher"
    },
    {
        id: 'bHay69s',
        name: "Cousin's B'day",
        date: "March/5/2021", // Date range
        description: "Cousin's B'day", // Event description (optional)
        type: "party",
        color: "#3c8dbc", // Event custom color (optional)
        icon: "birthday-cake"
    },
    {
        id: 'bHay70s',
        name: "Meditation Class",
        date: "March/17/2021", // Date range
        description: "Meditation Class", // Event description (optional)
        type: "event",
        color: "#63d867", // Event custom color (optional)
        icon: "chalkboard-teacher"
    },
    {
        id: 'bHay70s',
        name: "Meeting",
        date: "March/24/2021", // Date range
        description: "Meeting Important", // Event description (optional)
        type: "meeting",
        color: "#dd4b39", // Event custom color (optional)
        icon:"handshake"
    },
    {
        id: 'bHay70s',
        name: "Yoga Class",
        date: "March/30/2021", // Date range
        description: "Yoga Class", // Event description (optional)
        type: "event",
        color: "#63d867", // Event custom color (optional)
        icon: "chalkboard-teacher"
    },
    {
        id: 'bHay69s',
        name: "Sister's Marriage",
        date: "March/19/2021", // Date range
        description: "Marriage", // Event description (optional)
        type: "party",
        color: "#3c8dbc", // Event custom color (optional)
        icon: "birthday-cake"
    }];

var active_events = [];

var week_date = [];

var curAdd, curRmv;

function getRandom(a) {
    return Math.floor(Math.random() * a);
}

function getWeeksInMonth(a, b) {
    var c = [], d = new Date(b, a, 1), e = new Date(b, a + 1, 0), f = e.getDate();
    var g = 1;
    var h = 7 - d.getDay();
    while (g <= f) {
        c.push({
            start: g,
            end: h
        });
        g = h + 1;
        h += 7;
        if (h > f) h = f;
    }
    return c;
}

week_date = getWeeksInMonth(today.getMonth(), today.getFullYear())[2];

$(document).ready(function () {
    $("#demoEvoCalendar").evoCalendar({
        format: "MM dd, yyyy",
        titleFormat: "MM",
        format: "MM dd, yyyy",
        titleFormat: "MM",
        theme: 'Royal Navy',
        sidebarDisplayDefault: false,
        sidebarToggler: false,
        calendarEvents: [
            {
                id: 'bHay68s', // Event's ID (required)
                name: "Personal Traning", // Event name (required)
                //badge: "03/01 - 03/31", // Event badge (optional)
                description: "PT for Gym", // Event description (optional)
                date: "March/06/2021", // Date range
                //date: ["March/1/2021", "March/31/2021"], // Event date (required)
                type: "event", // Event type (required)
                color: "#63d867", // Event custom color (optional)
                icon: "chalkboard-teacher"
            },
            {
                id: 'bHay69s',
                name: "John's Birthday",
                date: "March/08/2021", // Date range
                description: "John's Birthday", // Event description (optional)
                type: "party",
                color: "#3c8dbc", // Event custom color (optional)
                icon: "birthday-cake"
            },
            {
                id: 'bHay70s',
                name: "Meditation Class",
                date: "March/08/2021", // Date range
                description: "Meditation Class", // Event description (optional)
                type: "event", // Event type (required)
                color: "#63d867", // Event custom color (optional)
                icon: "chalkboard-teacher"
            },
            {
                id: 'bHay70s',
                name: "Meditation Class",
                date: "March/10/2021", // Date range
                description: "Meditation Class", // Event description (optional)
                type: "event", // Event type (required)
                color: "#63d867", // Event custom color (optional)
                icon: "chalkboard-teacher"
            },
            {
                id: 'bHay70s',
                name: "Meditation Class",
                date: "March/12/2021", // Date range
                description: "Meditation Class", // Event description (optional)
                type: "event", // Event type (required)
                color: "#63d867", // Event custom color (optional)
                icon: "chalkboard-teacher"
            },
            {
                id: 'bHay69s',
                name: "Marshal's Birthday",
                date: "March/15/2021", // Date range
                description: "Marshal's Birthday", // Event description (optional)
                type: "party",
                color: "#3c8dbc", // Event custom color (optional)
                icon: "birthday-cake"
            }]
    });
    $('#demoEvoCalendar').on('selectDate', function (event, newDate, oldDate) {
        //$('#demoEvoCalendar').evoCalendar('toggleEventList', true);
        var active_events = $('#demoEvoCalendar').evoCalendar('getActiveEvents');
        $('#external-events').html('');
        if (active_events.length) {
            $.each(active_events, function (i, items) {
                var taskContent = '<div class="modal-body eventlist ' + items.type + '"> ';
                taskContent += '<h4><i class="fas fa-' + items.icon + '"></i> ' + items.name + '</h4>' + items.description + '</div>';
                $('#external-events').append(taskContent);
            });
        }
    });
    //var divBtn = "<div class='action-buttons' style='padding-top:10%'> <button class='btn-action' id ='addBtn'> ADD EVENT</button > <button class='btn-action' id='removeBtn' disabled=''>REMOVE EVENT</button> </div >";

    //$('#demoEvoCalendar').find('.calendar-events').append(divBtn);
    $("[data-set-theme]").click(function (b) {
        a(b.target);
    });
    $("#addBtn").click(function (a) {
        curAdd = getRandom(events.length);
        $("#demoEvoCalendar").evoCalendar("addCalendarEvent", events[curAdd]);
        active_events.push(events[curAdd]);
        events.splice(curAdd, 1);
        if (0 === events.length) a.target.disabled = !0;
        if (active_events.length > 0) $("#removeBtn").prop("disabled", !1);
    });
    $("#removeBtn").click(function (a) {
        curRmv = getRandom(active_events.length);
        $("#demoEvoCalendar").evoCalendar("removeCalendarEvent", active_events[curRmv].id);
        events.push(active_events[curRmv]);
        active_events.splice(curRmv, 1);
        if (0 === active_events.length) a.target.disabled = !0;
        if (events.length > 0) $("#addBtn").prop("disabled", !1);
    });
    var active_events = $('#demoEvoCalendar').evoCalendar('getActiveEvents');
    if (!active_events.length) {
        $('#demoEvoCalendar').evoCalendar('toggleEventList', false);
    }
    else {
        $.each(active_events, function (i, items) {
            var taskContent = '<div class="modal-body eventlist '+items.type+'">';
            taskContent += '<h4><i class="fas fa-'+items.icon+'"></i> ' + items.name + '</h4>' + items.description + '</div>';
            $('#external-events').append(taskContent);
        });
    }
});



