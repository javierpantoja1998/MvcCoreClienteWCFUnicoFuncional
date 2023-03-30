using ReferenceCoches;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceCoches
    {
        private CochesContractClient client;

        public ServiceCoches(CochesContractClient client)
        {
            this.client = client;
        }

        public async Task<Coche[]> GetCochesAsync()
        {
            Coche[] cars = await client.GetCochesAsync();
            return cars;
        }

        public async Task<Coche> FindCoche(int idcoche)
        {
            Coche car = await client.FindCocheAsync(idcoche);
            return car;
        }
    }
}
