using System.Text.RegularExpressions;
using TUSTimetableAPI.Enums;

namespace TUSTimetableAPI.Models;

public class Timetable
{
	public int Id { get; set; }
	public string Group { get; set; }
	public Subject Subject { get; set; }
	public string Day { get; set; }
	public TimeSpan Duration { get; set; }
	public TimeOnly StartTime { get; set; }
	public TimeOnly EndTime { get; set; }
	public string TutorName { get; set; }
	public string Type { get; set; }
	public string Location { get; set; }
	public string LocationMap { get; set; }

	public Timetable(Groups group, Subject subject, string day, TimeSpan duration, TimeOnly startTime, string tutorName, string type, string location, string locationMap)
	{
		Group = SetGroup(group);
		Subject = subject;
		Day = day;
		TutorName = tutorName;
		Type = type;
		Location = location;
		LocationMap = locationMap;
		StartTime = startTime;
		EndTime = startTime.Add(duration);
		Duration = duration;
		//TutorName = 
	}

	private string SetGroup(Groups groupEnum)
	{
		var group = groupEnum switch
		{
			// Switch based on Groups
			Groups.SD1A => "Group A",
			Groups.SD1B => "Group B",
			Groups.SD1C => "Group C",
			Groups.SD2A => "Group A",
			Groups.SD2B => "Group B",
			Groups.SD2C => "Group C",
			Groups.SD3A => "Group A",
			Groups.SD3B => "Group B",
			Groups.SD3C => "Group C",
			_ => "Undefined Group"
		};

		return group;
	}
}