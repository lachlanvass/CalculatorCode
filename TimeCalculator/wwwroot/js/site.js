

function revealCode() {
	var section = document.getElementById("codeBlock");
	if (section.style.display === "none") {
		section.style.display = "block";
	} else {
		section.style.display = "none";
	}
}

function revealCalculator() {
	var section = document.getElementById("calculator");
	if (section.style.display === "none") {
		section.style.display = "block";
	} else {
		section.style.display = "none";
	}
}

function switchInputs() {
	// Get input values in variables
	var inputOneValue = document.getElementById(idOne).value;
	var inputTwoValue = document.getElementById(idTwo).value;

	// Switch input values

	document.getElementById(idTwo).value = inputOneValue;
	document.getElementById(idOne).value = inputTwoValue;

	

}


