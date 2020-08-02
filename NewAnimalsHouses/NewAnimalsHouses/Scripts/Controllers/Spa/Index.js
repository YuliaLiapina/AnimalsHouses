$('#newHouses').click(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Houses',
        success: function (data) {
            $('.list-container').empty().append(data);
            //var result = '<ul>';
            //for (var item in data) {
            //    result += '<li>' + item.Name + '</li>'
            //}
            //var endresult = result + '</ul>'
            //$('.list-container').empty().append(endresult);
        },
        error: function (msg) {
            alert('Server error', msg);
        }
    });
})
$('#newAnimals').click(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Animals',
        success: function (data) {
            $('.list-container').empty().append(data);
            //var result = '<ul>';
            //for (var item in data) {
            //    result += '<li>' + item.Name + '</li>'
            //}
            //var endresult = result + '</ul>'
            //$('.list-container').empty().append(endresult);
        },
        error: function (msg) {
            alert('Server error', msg);
        }
    });
})
