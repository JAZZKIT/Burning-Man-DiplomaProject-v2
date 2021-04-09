// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//============ TIMELINE ===============

var timelineSwiper = new Swiper('.timeline .swiper-container', {
    direction: 'vertical',
    loop: false,
    speed: 1600,
    pagination: '.swiper-pagination',
    paginationBulletRender: function (swiper, index, className) {
        var year = document.querySelectorAll('.swiper-slide')[index].getAttribute('data-year');
        return '<span class="' + className + '">' + year + '</span>';
    },
    paginationClickable: true,
    nextButton: '.swiper-button-next',
    prevButton: '.swiper-button-prev',
    breakpoints: {
        768: {
            direction: 'horizontal',
        }
    }
});


//============= CONTACT ===============

// Validating Empty Field
function check_empty() {
    if (document.getElementById('usrnm').value == "" || document.getElementById('email').value == "" || document.getElementById('message').value == "") {
        alert("Fill All Fields !");
    } else {
        document.getElementById('form').submit();
        alert("Form Submitted Successfully...");
    }
}

//Function To Display Popup
function div_show() {
    document.getElementById('abc').style.display = "block";
}

//Function to Hide Popup
function div_hide() {
    document.getElementById('abc').style.display = "none";
}

$(".sectioncontact").click(function () {
    $(this).hide();
});

$(".button").click(function () {
    $(".sectioncontact").show();
});


$(".icon-remove").click(function () {
    $(".sectioncontact").show();
});


//=================Table=======================

document.addEventListener("DOMContentLoaded", () => {
    const rows = document.querySelectorAll("td[data-href]");

    rows.forEach(row => {
        row.addEventListener("click", () => {
            window.location.href = row.dataset.href;


        });
    });
});