const search_city = () =>{
    let filter = document.getElementById("myInput").value.toLowerCase();

    let myTable = document.getElementById("myTable");
    let tr = myTable.getElementsByTagName("tr");
    for (var i=0; i<tr.length; i++){
        //tr[i] represent rows and [0] represent the first column (city)
        let td = tr[i].getElementsByTagName("td")[0];
        if (td){
            let textvalue = td.textContent || td.innerHTML;

            if (textvalue.toLowerCase().indexOf(filter) > -1){
                tr[i].style.display = "";
            }else{
                tr[i].style.display = "none";
            }
        }
    }
}