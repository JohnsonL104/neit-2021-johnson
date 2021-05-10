var tray = document.querySelector("#tray");
var middle = document.querySelector("#middle");

var tabs = document.querySelector("#tabs").children;
var fileName = document.querySelector("#fileName");
// console.log(fileName)

tray.addEventListener("click", function(){
    middle.classList.toggle("hidden")
})

for(var i = 0; i < tabs.length; i ++){
    tabs[i].addEventListener("click", function(e){
        for(var y = 0; y < tabs.length; y++){
            tabs[y].classList.remove("selected");
        }
        if(e.target.classList.length > 0){
            e.target.classList.add("selected")
            console.log( e.target.children[0].children[1].textContent)
            fileName.textContent = e.target.children[0].children[1].textContent;
        }else{
            if(e.target.parentElement.classList.length > 0){
                e.target.parentElement.classList.add("selected")
                fileName.textContent = e.target.parentElement.children[0].children[1].textContent;
            }else{
                if(e.target.parentElement.parentElement.classList.length > 0){
                    e.target.parentElement.parentElement.classList.add("selected")
                    fileName.textContent = e.target.parentElement.children[1].textContent;
                }
            }
        }
    })
}