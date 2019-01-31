<Query Kind="Expression">
  <Connection>
    <ID>7e9f5a5e-68da-43fc-b060-0b91c2adba8a</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>E:\Projects\GitHub Repository\GighubV2\GighubV2\bin\GighubV2.dll</CustomAssemblyPath>
    <CustomTypeName>GighubV2.Models.ApplicationDbContext</CustomTypeName>
    <AppConfigPath>E:\Projects\GitHub Repository\GighubV2\GighubV2\Web.config</AppConfigPath>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Entity.dll</Reference>
  <Namespace>System.Data</Namespace>
  <Namespace>System.Data.Common</Namespace>
  <Namespace>System.Data.Common.CommandTrees</Namespace>
  <Namespace>System.Data.Common.CommandTrees.ExpressionBuilder</Namespace>
  <Namespace>System.Data.Common.CommandTrees.ExpressionBuilder.Spatial</Namespace>
  <Namespace>System.Data.Common.EntitySql</Namespace>
  <Namespace>System.Data.EntityClient</Namespace>
  <Namespace>System.Data.Mapping</Namespace>
  <Namespace>System.Data.Metadata.Edm</Namespace>
  <Namespace>System.Data.Objects</Namespace>
  <Namespace>System.Data.Objects.DataClasses</Namespace>
  <Namespace>System.Data.Objects.SqlClient</Namespace>
  <Namespace>System.Data.Spatial</Namespace>
  <Namespace>System.Data.SqlClient</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

Attendances
	.Include(at => at.Attendee)
	.Include(at => at.Gig.Artist)
	.Where(at => !at.Gig.IsCanceled)
	.ToList()
	.Select(at => new { AttendeeName = at.Attendee.Name, Performer = at.Gig.Artist.Name, DateTime = at.Gig.DateTime } )
	


	
