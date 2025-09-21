function login(){
    window.location.href="Menu/dashboard.html";
}

function toggleMenu(){
    const menu = document.getElementById("sideMenu");
    const overlay = document.getElementById("overlay");

    menu.classList.toggle("active");
    overlay.style.display=menu.classList.contains("active")?"block":none;
}

function closeMenu(){
    document.getElementById("sideMenu").classList.remove("active");
    document.getElementById("overlay").style.display="none";
}

