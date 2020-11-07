function displayGroceries() {
		var request = new XMLHttpRequest();
		request.open("GET", "XMLFile.xml", false);
		request.setRequestHeader("content-type", "text/xml");
		request.send();

		console.write("testing");

		var groceriesXML = request.responseXML;
		var groceriesList = groceriesXML.childNodes[0];

		for (var i = 0; i < groceriesList.lastChild.length; i++) {
			var groceryType = groceriesList.children[i];
			var vegetables = groceryType.getElementsByTagName("vegetable");
			document.write(vegetables[0].textContent.toString());
		}
}
