using TUSTimetableAPI.Models;

namespace TUSTimetableAPI.Services.TimetableService;

public interface ITimetableService
{
	Task<ServiceResponse<Timetable>> CreateNewTimetableBlock(Timetable timetable);
	Task<ServiceResponse<Timetable>> GetCurrentTimetableBlock();
	Task<ServiceResponse<Timetable>> GetSpecificTimetableBlock(string day, TimeOnly startTime);
	Task<ServiceResponse<List<Timetable>>> GetAllTimetableBlocks();
	Task<ServiceResponse<List<Timetable>>> GetAllTimetableBlocksForDay(string day);
	Task<ServiceResponse<Timetable>> UpdateTimetableBlock(string day, TimeOnly startTime);
	Task<ServiceResponse<Timetable>> UpdateTimetableBlockById(int id);
	Task<ServiceResponse<bool>> DeleteTimetableBlock(string day, TimeOnly startTime);
	Task<ServiceResponse<bool>> DeleteTimetableBlockById(int id);
}