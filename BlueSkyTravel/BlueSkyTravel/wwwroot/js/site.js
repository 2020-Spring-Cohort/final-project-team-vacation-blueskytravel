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
