# Factory
#### An MVC web application for Manufacturers to track their Equipment and Licensed Engineers

#### By Brent Hickman

## Technologies Used

* C#
* Dotnet 6
* Entity Framework Core
* MySQL
* Html
* Css


## Factory is an MVC application built for Dr. Sillystringz's Factory. Users can add Machines to their equipment list and Engineers to their technician list. They can then mark which Engineers are licensed to repair which Machines. 

## Setup/Installation Requirements

* Open a terminal window and clone this repository by entering into the command line:
> git clone https://github.com/BrentHickman/Factory.Solution.git
* In the terminal, navigate to the console application with the command:
> cd Salon.Solution/Factory
* Once in the "Factory" directory, create a new file called appsettings.json
* Within appsettings.json, put in the following code, replacing the [YOURUSERNAME] and [YOURPASSWORD] values with your own username and password for MySQL.
>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOURUSERNAME];pwd=[YOURPASSWORD];"
  }
}
* Next, enter the following into the command line:
> dotnet ef database update
* To launch the application in development mode, enter the following lines into the command line:
> dotnet restore
* then:
> dotnet watch run
* The application should the be available at:
> https://localhost:5001/

## Known Bugs

* If you are experiencing any bugs, please contact me at brenthickman@ymail.com

## License

* [MIT](https://opensource.org/licenses/MIT)
* Brent Hickman 3/17/23