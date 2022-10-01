using TUSTimetableAPI.Models;

namespace TUSTimetableAPI.Services.TimetableService;

public class TimetableService : ITimetableService
{
	public async Task<ServiceResponse<Timetable>> CreateNewTimetableBlock(Timetable timetable)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<Timetable>> GetCurrentTimetableBlock()
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<Timetable>> GetSpecificTimetableBlock(string day, TimeOnly startTime)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<List<Timetable>>> GetAllTimetableBlocks()
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<List<Timetable>>> GetAllTimetableBlocksForDay(string day)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<Timetable>> UpdateTimetableBlock(string day, TimeOnly startTime)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<Timetable>> UpdateTimetableBlockById(int id)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<bool>> DeleteTimetableBlock(string day, TimeOnly startTime)
	{
		throw new NotImplementedException();
	}

	public async Task<ServiceResponse<bool>> DeleteTimetableBlockById(int id)
	{
		throw new NotImplementedException();
	}
}