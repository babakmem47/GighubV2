using System;

public class Class1
{
	public Class1()
	{
		////// Get All Attendee(by Name) and their gigs(by Name of Artist and Date of Gig)
		Attendances
			.Include(a => a.Attendee)
			.Include(a => a.Gig.Artist)
			.ToList()
			.Select(a => new
				{
					AttendeeName = a.Attendee.Name,
					GigName = a.Gig.Artist.Name,
					GigDate = a.Gig.DateTime
				}
			);


	}
}

