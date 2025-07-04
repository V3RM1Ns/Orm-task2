using Orm_Task2.BL.Dtos.GroupDto;
using Orm_Task2.DAL.Repositories.Concretes;
using Orm_Task2.DAL.Repositories.Interfaces;

namespace Orm_Task2.BL.Services.Concretes;

public class GroupService: IGroupService
{
    private readonly IRepository<Group> _repository;

    public GroupService()
    {
        _repository = new Repository<Group>();;
    }
    public void CreateGroup(GroupCreateDto groupdto)
    {
        Group group = GroupProfile.GroupCreateToGroup(groupdto);
       _repository.Add(group);
    }

    public void UpdateGroup(GroupCreateDto groupdto)
    {
        Group group = GroupProfile.GroupCreateToGroup(groupdto);
        _repository.Update(group);
    }

    public void DeleteGroup(GroupCreateDto groupdto)
    {
        Group group = GroupProfile.GroupCreateToGroup(groupdto);
        _repository.Delete(group);
    }

    public Group GetById(int id)
    {
       return _repository.GetById(id);
    }
}