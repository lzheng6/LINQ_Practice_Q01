<Query Kind="Statements">
  <Connection>
    <ID>fb9d85aa-23da-413c-979d-9feb552ec2a4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from g in Genres
			orderby g.Name
			select new
			{
			Genre=g.Name,
			TracksCount=g.Tracks.Count()
			};
results.Dump("Query Math");