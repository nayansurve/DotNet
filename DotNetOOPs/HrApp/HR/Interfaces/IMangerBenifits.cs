//Creating interface  inheritance

namespace HR.Interfaces;

public interface IManagerBenifits : IBonusEligible, IAppraisable
{
    void  AproveLeave();
}