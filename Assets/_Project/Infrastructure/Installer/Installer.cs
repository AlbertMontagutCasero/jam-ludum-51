using _Project.Dao;
using _Project.Interactor;
using UnityEngine;

namespace _Project.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {
        private void Awake()
        {

            // DOMAIN
            
            // DAO
            DaoServiceLocator.GetInstance().RegisterService(new DaoEntity1());
            
            // INTERACTOR
            InteractorServiceLocator.GetInstance().RegisterService(new Example1Interactor());       
        }
    }
}