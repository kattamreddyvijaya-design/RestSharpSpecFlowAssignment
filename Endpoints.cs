namespace RestSharpSpecFlowSkeleton;

public static class Endpoints
{
    public static string CreatePet = "/pet";
    public static string CreateUser = "/user/createWithList";
    public static string CreateOrder = "/store/order";
    public static string FindPetsByStatus = "/pet/findByStatus";
    public static string UpdatePet = "/pet";

    public static string PetById(string id) => $"/pet/{id}";
    public static string UserByName(string name) => $"/user/{name}";
    public static string GetOrderById(string id) => $"/store/order/{id}";
}
