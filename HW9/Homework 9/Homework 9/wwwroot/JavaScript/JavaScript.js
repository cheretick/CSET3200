var username = "cheretick";
var password = "password";

function checkLogin() {
	var enteredUsername = document.getElementById("username").value;
	var enteredPassword = document.getElementById("password").value;

	if ((username == enteredUsername) && (password == enteredPassword)) {
		alert("Login successful!");
		redirect();
		return false;
	} else {
		alert("Invalid credentials. Please, try again.");
	}
}

function redirect() {
	window.location = "index.html";
}