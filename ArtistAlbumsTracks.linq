<Query Kind="Statements">
  <Connection>
    <ID>5ef4b049-1e05-412c-8a4f-0dd25ed780be</ID>
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
					GeneId=tr.GenreId,
					Composer=tr.Composer,
					Milliseconds=tr.Milliseconds
					}
				}
			};
results.Dump();