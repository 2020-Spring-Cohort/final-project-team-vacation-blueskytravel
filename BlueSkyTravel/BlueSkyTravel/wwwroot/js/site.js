// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const button = document.querySelectorAll("#addVote").forEach(button => {
    button.onclick = function () {
        console.log("hello!")
        addVote()
    }
})

function addVote() {
    let vote = document.querySelector("#voteCount").value
    vote++
    console.log(vote)
}


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