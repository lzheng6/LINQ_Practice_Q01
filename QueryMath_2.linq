<Query Kind="Statements">
  <Connection>
    <ID>fb9d85aa-23da-413c-979d-9feb552ec2a4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from g in Genres
			where g.Name.Equals("Heavy Metal")
			select new
			{
			TracksCount=g.Tracks.Count(),
			Tracks=from t in g.Tracks
				select new
				{
				TrackName=t.Name,
				AlbumName=t.Album.Title,
				Milliseconds=t.Milliseconds,
				Size=(t.Bytes/1000)+"kb",
				Price=t.UnitPrice
				}
			};
results.Dump("More math");