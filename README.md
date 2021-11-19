# Booking.com Serializer
# Web Extraction 


<div id="top"></div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

this is a data extractor that reads out content from "extraction.booking.html" and extracts the below listed information.  

# Input 

Html content taken from `extraction.booking.html`

# Output 

output format: `JSON string`

file name: `Hotel.json`

# Model
Hotel Model:
* Hotel name
* Address
* Classification
* Review points
* Number of reviews
* Description
* Room categories
* Alternative hotels

<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [.Net 6](https://dotnet.microsoft.com/download/dotnet/6.0/)
* [Html Agility Pack](https://html-agility-pack.net/)
* [NUnit](https://nunit.org/)
* [fluentassertions](https://fluentassertions.com/)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* download .Net 6 runtime from this address: https://dotnet.microsoft.com/download/dotnet/6.0/

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/CodingBrushUp/Booking_com_Serializer.git
   ```
2. copy `Resources` folder to your C:\ (our feed is in this folder)



go to the project root folder, run `cmd` on url bar to open command prompt

# to build and run project:

run these commands:
```sh
dotnet restore
dotnet build
dotnet run --project ./Task1/Task1.csproj
```

# to test project:

```sh
dotnet test
```
<p align="right">(<a href="#top">back to top</a>)</p>


<!-- ACKNOWLEDGMENTS -->
## Note:

1. we have a variety of libraries for Web Crawling such as HttpAgility, Selenium, etc. Selenium is a better choice for real projects.
2. ...
<p align="right">(<a href="#top">back to top</a>)</p>

### contact
contact[at]alihaghighi[dot]pro

https://www.linkedin.com/in/ali-s-haghighi/

<!-- MARKDOWN LINKS & IMAGES -->
[product-screenshot]: images/screenshot.png
