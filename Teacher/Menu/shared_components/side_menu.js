

function side_menubar(targetId){
    document.getElementById(targetId).innerHTML = `
<div class="Top-Bar">
            <div class="merge-sideMenu-search">
            <button class="hamburger" onclick="toggleMenu()">
                ☰
            </button>
            <form action="/search" method="get">
            <input type="text" name="query" placeholder="...">    
            <button class="search-icon" type="Submit">&#128269;</button>
            </form>
            </div>
            <button >&#9881;</button>
        </div>
        <div id="overlay" class="overlay" onclick="closeMenu()"></div>
        <nav id="sideMenu" class="side-menu">
                <a class="profile-image"></a>
                <a href="">Dashboard</a>
                <a href="subjects.html">Subjects</a>
                <a href="">Settings</a>
                <a href="">Help</a>
                <a href="../login.html" class="back-button">&#8592;</a>
            </nav>
`
            }