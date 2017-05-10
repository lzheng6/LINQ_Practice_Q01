<Query Kind="Statements">
  <Connection>
    <ID>fb9d85aa-23da-413c-979d-9feb552ec2a4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from m in MediaTypes
			select new
			{
			Name=m.Name,
			Tracks=from t in m.Tracks
			select new
				{
				TrackName=t.Name,
				Album=t.Album.Title,
				
				Artist=t.Album.Artist.Name,
				ReleaseYear=t.Album.ReleaseYear,
				ReleaseLable=t.Album.ReleaseLabel,
				Genre=t.Genre.Name
				
				}

			};
results.Dump("Version 5");