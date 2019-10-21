using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMvc.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CategoryName",
                value: "Freddie Kitchens");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CategoryName",
                value: "Baker Mayfield");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CategoryName",
                value: "Nick Chubb");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CategoryName",
                value: "2019 Schedule");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "BK", "Kitchens’ thick Southern drawl hugs every syllable that flows from his mouth. But don’t mistake Kitchens for a dolt.  18 years after coaching for Saban, Kitchens has slowly worked his way up the ladder to become an NFL head coach. Kitchens coached for four other teams between his time with LSU and the Browns. He spent all of that time as either a quarterbacks coach, running backs coach, or tight ends coach.", "/Images1/FredK1.jpeg", "Impressions so far on Freddie Kitchens" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "BK", "What’s wrong? Well, just about everything. When an offense faceplants to this degree, there isn’t just one culprit. But let’s start with versatility in personnel groupings. Per Sharp Football Analysis, the Browns are running 11 personnel (one running back, one tight end, three wide receivers) on 84% of their offensive snaps. That’s one of the highest rates in the NFL, and in line with the Rams as Sean McVay has become the king of 11 personnel. In fact, the Rams, who ran 11 personnel on 94% of their plays last season, are running it just 83% of the time in 2019, as McVay endeavors to upset defenses who have stacked their schemes to counter his previous predictability.", "/Images1/BakerM1.jpeg", "What's Wrong with Baker?" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "BK", "As a standout track & field athlete, Chubb competed from 2011 to 2015 in events ranging from the 100-meters to the shot put. At the 2013 4A Sectionals, he took fifth place in the long jump event with a leap of 6.85 meters (22 ft, 4 in).[3] At the 2014 4A Sectionals, he won the shot put event, recording a top-throw of 17.05 meters (55 ft, 8in), and earned second-place finishes in both the 100-meter dash, with a time of 10.69 seconds (setting a school record), and the 200-meter dash, with a time of 21.83 seconds.[4] He captured the state title in the shot put at the 2014 Class AAAA with a throw of 16.77 meters (55 ft).", "/Images1/NickC1.jpeg", "Lookout NFL... Nick Chubb is a beast!" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "BK", "This is the game Breech listed as the make-or-break game for the Browns, and I agree wholeheartedly. Everyone is assuming the Browns are going to steamroll the Titans because the Titans are boring and the Browns are the Hansel of the NFL. The Browns are a 5.5-point favorite over Tennessee at home. The Browns have been 5.5-point favorites eight times in the last 15 years. They covered three of those games. I'm not saying they won't win the game or even not cover, but the hype is cascading out of control on this team. The Titans nearly made the playoffs last year, have an underrated roster, will try to come in and pound the ball with Derrick Henry and could steal this game. It would send shockwaves through Cleveland if Tennessee pulled off the upset. ", "/Images1/BSched1.jpeg", "The Browns Schedule is not very friendly" });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 1,
                column: "TagName",
                value: "Freddie Kitchens");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 2,
                column: "TagName",
                value: "Baker Mayfield");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 3,
                column: "TagName",
                value: "Nick Chubb");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 4,
                column: "TagName",
                value: "2019 Schedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CategoryName",
                value: "Fun");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CategoryName",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CategoryName",
                value: "Sun");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CategoryName",
                value: "Other");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "hj", "Shakespeare", "/images/.jpeg", "William" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "hj", "Shakespeare", "/images/.jpeg", "William" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "hj", "Shakespeare", "/images/.jpeg", "William" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Author", "Body", "Image", "Title" },
                values: new object[] { "hj", "Shakespeare", "/images/.jpeg", "William" });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 1,
                column: "TagName",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 2,
                column: "TagName",
                value: "Sun");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 3,
                column: "TagName",
                value: "Fun");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 4,
                column: "TagName",
                value: "Other fun Stuff");
        }
    }
}
