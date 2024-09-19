Console.WriteLine("Hello, Czechia!");

//*
// Hello,

// Here i assumed we get the all year-months pair from api call, i dont know the project size. if this data getting from complex way we should pass 2 parameters
// (monthIndex, year) -> and we can get just days. so when user click each year or month, we send a request and get days and render into calender.


// as i mention above i assume we got ALL year/months pair as a response. So FE developer render the months (selectable or not) and ALL years. (top side)
// we will going to return CalenderResponseModel[] as an api result.
// FE dev. will going to render years and months. When user click specific month/year, developer going to render related dayData[] and render it into his/her calender.


// please check the dummy.json because in my case he/she will get the array of CalenderResponseModel[] and i just put the oct/2019 until 20th of month.


// please feedback, thank you in advance.

// :) 
//*/