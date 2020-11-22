namespace ASdatabase
{
    public interface IActualizationContentRepository : IRepository<ActualizationContent>
    {
        void UpdateActualizationContent(int IdZarzadzenie, ActualizationContent actualizationContent);
        void Delete(ActualizationContent actualizationContent);
        ActualizationContent FindActualizationContentByZarzadzenieId(int IdZarzadzenie);
        ActualizationContent FindActualizationContentById(int IdActualizationContent);

    }
}