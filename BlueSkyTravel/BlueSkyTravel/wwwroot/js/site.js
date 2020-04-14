// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Budget Balance Calculator
let flightFareSum = 0
let flightFares = document.querySelectorAll("#flightFare").forEach(flightFare => {
    flightFareSum = flightFareSum + +flightFare.value
})

let hotelRateSum = 0
let hotelRates = document.querySelectorAll("#hotelRate").forEach(hotelRate => {
    hotelRateSum = hotelRateSum + +hotelRate.value
})

let activityFareSum = 0
let activityFares = document.querySelectorAll("#activityFare").forEach(activityFare => {
    activityFareSum = activityFareSum + +activityFare.value
})

console.log(flightFareSum)
console.log(hotelRateSum)
console.log(activityFareSum)

let totalBudget = document.getElementById("budget").getAttribute('value')
console.log(totalBudget)

let totalBalanceElement = document.querySelector("#balance")
let totalBalance = totalBudget - flightFareSum - hotelRateSum - activityFareSum
totalBalanceElement.innerText = "Remaining Budget: $" + totalBalance.toFixed(2)
console.log(totalBalance)

//Vacation Countdown
const second = 1000,
    minute = second * 60,
    hour = minute * 60,
    day = hour * 24;

let startDate = document.querySelector("#countdown-value").getAttribute('value')
console.log(startDate)

let countDown = new Date(startDate).getTime()

    console.log(countDown)

    x = setInterval(function () {

        let now = new Date().getTime(),
            distance = countDown - now;

        document.getElementById('days').innerText = Math.floor(distance / (day)),
            document.getElementById('hours').innerText = Math.floor((distance % (day)) / (hour)),
            document.getElementById('minutes').innerText = Math.floor((distance % (hour)) / (minute)),
            document.getElementById('seconds').innerText = Math.floor((distance % (minute)) / second);

        
        if (distance < 0)
        {
          clearInterval(x);
          document.getElementById('countdown-timer').innerHTML = "It's Vacation Time!!!";
        }

    }, second)