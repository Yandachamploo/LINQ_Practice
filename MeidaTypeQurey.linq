<Query Kind="Statements">
  <Connection>
    <ID>0d303774-c6e8-4b0c-95d3-8ce7f3fe4e73</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes	
			  select new
			  {
			  Name = m.Name,
			  Tracks = from t in m.Tracks
			  select new
				{
				TrackName = t.Name,
			 
			 
			   Aritst = t.Album.Artist.Name,
			   ReleaseYear = t.Album.ReleaseYear,
			   ReleaseLabel =t.Album.ReleaseLabel
			   
				}
			
			  };
results.Dump();
			  