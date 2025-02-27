using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IComplaintService
    {
        Task<ApiResponse<List<ComplaintDetailDto>>> GetBuildingComplaintsAsync(int buildingId);
        Task<ApiResponse<ComplaintDetailDto>> GetComplaintDetailAsync(int complaintId);
        Task<ApiResponse<List<ComplaintDetailDto>>> GetUserComplaintsAsync(int userId);
        Task<ApiResponse<Complaint>> CreateComplaintAsync(Complaint complaint);
        Task<ApiResponse<bool>> ResolveComplaintAsync(int complaintId, int adminId);
        Task<ApiResponse<bool>> DeleteComplaintAsync(int complaintId);
        Task<ApiResponse<int>> GetActiveComplaintsCountAsync(int buildingId);
    }
} 