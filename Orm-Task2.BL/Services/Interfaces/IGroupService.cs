using Orm_Task2.BL.Dtos.GroupDto;

namespace Orm_Task2.BL.Services.Interfaces;

public interface IGroupService
{
    public void CreateGroup(GroupCreateDto groupdto);
    public void UpdateGroup(GroupCreateDto groupdto);
    public void DeleteGroup(GroupCreateDto groupdto);
    public Group GetById(int id);
}