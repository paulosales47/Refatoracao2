using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao2.Aula01
{
    public class Aluno
    {
        private IList<string> _cursos;

        public IReadOnlyCollection<string> Cursos
        {
            get => new ReadOnlyCollection<string>(_cursos);
        }
    }
}
