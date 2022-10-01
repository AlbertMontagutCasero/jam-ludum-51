using System.Collections.Generic;

namespace LudumDare51.Interactor
{
    public struct CommandSelectedResponse
    {
        public List<CommandDto> commandDto;
        
        public float GetNumberOfSelected()
        {
            return this.commandDto.Count;
        }
    }
}