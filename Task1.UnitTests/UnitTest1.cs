using HtmlAgilityPack;
using FluentAssertions;
using NUnit.Framework;
using System.IO;

namespace Task1.UnitTests
{
    public class Tests
    {
        string _docUrl;
        HtmlDocument _doc = new();

        [SetUp]
        public void Setup()
        {
            _docUrl = $"c:\\Resources\\task 1 - Kempinski Hotel Bristol Berlin, Germany - Booking.com.html";
            _doc.Load(_docUrl);
        }

        [Test]
        public void document_shoud_not_be_null()
        {
            _doc.Should().NotBeNull();
        }

        [Test]
        public void document_has_valid_html_structure()
        {
            var node = _doc.DocumentNode.SelectSingleNode("//body").Name;
            node.Should().Be("body");
        }

        [Test]
        public void document_has_7_room_types()
        {
            int cnt = _doc.DocumentNode.SelectNodes("//td[@class='ftd']").Count;
            cnt.Should().Be(7);
        }

        [Test]
        public void document_has_4_Alternative_Hotels()
        {
            int cnt = _doc.DocumentNode.SelectNodes("//a[@class='althotel_link']").Count;
            cnt.Should().Be(4);
        }
        
        [Test]
        public void hotel_name_should_not_be_null()
        {
            var node = _doc.GetElementbyId("hp_hotel_name").InnerHtml.Trim();
            node.Should().NotBeNull();
        }

        [Test]
        public void directory_exist()
        {
            string dirStr = $"c:\\Resources";
            Assert.That(dirStr, Does.Exist);
        }

        [Test]
        public void result_file_writeable()
        {
            string fileName = $"c:\\Resources\\test.json";
            using FileStream createStream = File.Create(fileName);
            
            Assert.That(fileName, Does.Exist);
            createStream.Close();

            File.Delete(fileName);
            Assert.That(fileName, Does.Not.Exist);
        }

    }
}