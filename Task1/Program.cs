using HtmlAgilityPack;
using System.Text.Json;
using Task1.Models;

string fileName = "c:\\Resources\\Hotel.json";
string docUrl = $"c:\\Resources\\task 1 - Kempinski Hotel Bristol Berlin, Germany - Booking.com.html";

var doc = new HtmlDocument();
doc.Load(docUrl);

await SaveToJsonFile(GetHotelInfo(doc), fileName);

Console.WriteLine(File.ReadAllText(fileName));

Hotel GetHotelInfo(HtmlDocument doc)
{
    Hotel hotel = new();
    hotel.HotelName = getInnerHtmlById(doc, "hp_hotel_name");
    hotel.ReviewPoints = getInnerHtmlByClass(doc, "//span[contains(@class,'average js--hp-scorecard-scoreval')]");
    hotel.NumberOfReviews = getInnerHtmlByClass(doc, "//span[contains(@class,'trackit score_from_number_of_reviews')]//strong[@class='count']");
    hotel.Classification = getInnerHtmlByClass(doc, "//span[contains(@class,'js--hp-scorecard-scoreword')]");
    hotel.Address = getInnerHtmlById(doc, "hp_address_subtitle");
    hotel.Description = getInnerHtmlById(doc, "summary");

    hotel.RoomCategories = doc.DocumentNode.SelectNodes("//td[@class='ftd']").Select(x => x.InnerHtml.Trim()).ToList();
    hotel.AlternativeHotels = doc.DocumentNode.SelectNodes("//a[@class='althotel_link']").Select(x => x.GetAttributeValue("href", String.Empty).Trim()).ToList();
    return hotel;
}
string getInnerHtmlById(HtmlDocument doc, string Id)
{
        return doc?.GetElementbyId(Id)?.InnerHtml?.Trim() ?? String.Empty;
}
string getInnerHtmlByClass(HtmlDocument doc, string className)
{
    return doc?.DocumentNode?.SelectNodes(className)?.FirstOrDefault()?.InnerHtml?.Trim() ?? String.Empty;
}
async Task SaveToJsonFile(Hotel hotel, string fileName)
{
    using FileStream createStream = new(fileName, FileMode.Create);
    if (createStream.CanWrite)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        await JsonSerializer.SerializeAsync(createStream, hotel, options: options);
        await createStream.DisposeAsync();
    }
}
