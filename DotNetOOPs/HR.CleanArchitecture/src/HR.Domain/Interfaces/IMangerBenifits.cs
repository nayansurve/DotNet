namespace HR.Domain.Entities;



public interface IManagerBenifits : IBonusEligible, IAppraisable
{
    void  AproveLeave();
}