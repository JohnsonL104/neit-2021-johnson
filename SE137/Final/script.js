var img = document.querySelector(".jumbotron");
var ig = document.querySelector(".fa-instagram-square")
var twitter = document.querySelector(".fa-twitter-square")
var github = document.querySelector(".fa-github-square")



ig.addEventListener("click", function(){
    window.open("https://instagram.com/", '_blank')
})
twitter.addEventListener("click", function(){
    window.open("https://twitter.com/", '_blank');
})
github.addEventListener("click", function(){
    window.open("https://github.com/JohnsonL104/neit-2021-johnson", '_blank');
})
img.addEventListener("click", function(){
    window.open("featuredProject.html", '_self');
})



// things to do:
// 1. make pictures clickable