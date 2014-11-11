function clickHandler(e) {
    //var target = e.target;
    //var password = prompt("What is the password?", "");
    //document.getElementById("Password").value = password;
    //document.forms["hiddenForm"].submit();
}

function getCookie(cookie) {
    cookieArray = new Array();
    cookieArray = document.cookie.split('; ');
    for (i = 0; i < cookieArray.length; i++) {
        keyName = new Array();
        keyName = cookieArray[i].split('=');
        if (keyName[0] == cookie) {
            return keyName[1];
        }
    }
    return null;
}

function setCookie(name, value, expires, path, domain, secure) {
    cookieStr = name + "=" + escape(value) + "; ";

    if (expires) {
        expires = setExpiration(expires);
        cookieStr += "expires=" + expires + "; ";
    }
    if (path) { cookieStr += "path=" + path + "; "; }
    if (domain) { cookieStr += "domain=" + domain + "; "; }
    if (secure) { cookieStr += "secure; "; }

    document.cookie = cookieStr;
}

function setExpiration(cookieLife) {
    var today = new Date();
    var expr = new Date(today.getTime() + cookieLife * 24 * 60 * 60 * 1000);
    return expr.toGMTString();
}

function setTheme(theme) {
    if (theme == null) theme = getCookie("theme");
    if (theme == "dark") {
        document.getElementById("pagestyle").setAttribute("href", "/Content/" + theme + ".css");
        $('#darkTheme').removeClass("fa-circle-o").addClass("fa-circle");
        $('#defaultTheme').removeClass("fa-circle").addClass("fa-circle-o");
    }
    else {
        document.getElementById('pagestyle').setAttribute('href', '/Content/default.css');
        $('#darkTheme').removeClass("fa-circle").addClass("fa-circle-o");
        $('#defaultTheme').removeClass("fa-circle-o").addClass("fa-circle");
    }
    $('#themeSwitcher').css("display", "block");
}

function changeTheme(theme) {
    if (theme != getCookie("theme")) {
        setCookie('theme', theme, 3, '/');
        setTheme(theme);
    }
}

$(function () {
    $(document).keypress(function (event) {
        if (event.which == 48) {
            // if numpad 0 do something
        }
    });
});