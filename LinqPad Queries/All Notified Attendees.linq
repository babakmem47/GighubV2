<Query Kind="Expression">
  <Connection>
    <ID>7e9f5a5e-68da-43fc-b060-0b91c2adba8a</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>E:\Projects\GitHub Repository\GighubV2\GighubV2\bin\GighubV2.dll</CustomAssemblyPath>
    <CustomTypeName>GighubV2.Models.ApplicationDbContext</CustomTypeName>
    <AppConfigPath>E:\Projects\GitHub Repository\GighubV2\GighubV2\Web.config</AppConfigPath>
  </Connection>
</Query>

UserNotifications
	.Include(un => un.User)
	.Include(un => un.Notification.Gig.Artist)
	.ToList()
	.Select(un => new { Attendee = un.User.Name, Performer = un.Notification.Gig.Artist.Name})