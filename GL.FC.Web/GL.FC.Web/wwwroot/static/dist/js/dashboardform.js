// Code By Webdevtrick ( https://webdevtrick.com )
$('.button').click(function () {
    var $btn = $(this),
        $step = $btn.parents('.modal-body'),
        stepIndex = $step.index(),
        $pag = $('.header span').eq(stepIndex);

    if (stepIndex === 0 || stepIndex === 1) { step1($step, $pag); }
    else { step3($step, $pag); }

});


function step1($step, $pag) {
    console.log('step1');
    // animate the step out
    $step.addClass('animate-out');

    // animate the step in
    setTimeout(function () {
        $step.removeClass('animate-out is-showing')
            .next().addClass('animate-in');
        $pag.removeClass('active')
            .next().addClass('active');
    }, 600);

    // after the animation, adjust the classes
    setTimeout(function () {
        $step.next().removeClass('animate-in')
            .addClass('is-showing');

    }, 1200);
}


function step3($step, $pag) {
    console.log('3');

    // animate the step out
    $step.parents('.container').addClass('animate-up');

    setTimeout(function () {
        $('.reStart').css('display', 'inline-block');
    }, 300);
}

$('.reStart').click(function () {
    $('.container').removeClass('animate-up')
        .find('.modal-body')
        .first().addClass('is-showing')
        .siblings().removeClass('is-showing');

    $('.header span').first().addClass('active')
        .siblings().removeClass('active');
    $(this).hide();
});