<Query Kind="Statements">
  <Connection>
    <ID>fb9d85aa-23da-413c-979d-9feb552ec2a4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results=from a in Artists
			where a.ArtistId==1
			orderby a.Name 
			select new
			{
			Artist=a.Name,
			Albums=from t in a.Albums
					orderby t.Title
					select new
				{
				Title=t.Title,
				Tracks=from tr in t.Tracks
						select new
					{
					TrackName=tr.Name,
					Genre=tr.Genre.Name,
					MediaType=tr.MediaType.Name,
					Composer=tr.Composer,
					Milliseconds=tr.Milliseconds
					}
				}
			};
results.Dump();