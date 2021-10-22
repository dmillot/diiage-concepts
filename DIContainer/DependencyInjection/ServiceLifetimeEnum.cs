namespace DIContainer.DependencyInjection
{
    public enum ServiceLifetimeEnum
    {
        // Pour chaque objet qui fera appel à ce service, le conteneur d'IoC va fournir une seule et même instance.
        // Le service est créé pour le premier qui en fait la demande.
        Singleton,
        
        // Pour chaque objet qui fera appel à ce service, le conteneur d'IoC va fournir une instance de ce dernier.
        // Une instance du service ne sera jamais partagée à plus d'un objet par le conteneur d'IoC.
        Transient,
        
        // Pour une requête HTTP vers l’application, tous les objets qui utilisent le service recevront la même instance de ce dernier du
        // conteneur d’IoC.
        Scoped
    }
}