function clickHandler(e) {
    var target = e.target;
    var password = prompt("What is the password?", "");
    document.getElementById("Password").value = password;
}