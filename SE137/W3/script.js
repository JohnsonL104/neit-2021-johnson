var nbis = document.querySelector("#nbisCol");
var vt = document.querySelector("#vtCol");
var neit = document.querySelector("#neitCol");
nbis.addEventListener("click", function(){
    window.open("https://nbis.northbranfordschools.org/en-US", "_blank");
})
nbis.addEventListener("mouseover", function(){
    document.body.style.cursor = "pointer";
    nbis.style.backgroundColor = "#3d3d3d"
})
nbis.addEventListener("mouseout", function(){
    document.body.style.cursor = "default";
    nbis.style.backgroundColor = "#323232"
})


vt.addEventListener("click", function(){
    window.open("https://vinal.cttech.org/", "_blank");
    
})
vt.addEventListener("mouseover", function(){
    document.body.style.cursor = "pointer";
    vt.style.backgroundColor = "#3d3d3d"
})
vt.addEventListener("mouseout", function(){
    document.body.style.cursor = "default";
    vt.style.backgroundColor = "#323232"
})


neit.addEventListener("click", function(){
    window.open("https://www.neit.edu/", "_blank");
})
neit.addEventListener("mouseover", function(){
    document.body.style.cursor = "pointer";
    neit.style.backgroundColor = "#3d3d3d"
})
neit.addEventListener("mouseout", function(){
    document.body.style.cursor = "default";
    neit.style.backgroundColor = "#323232"
})