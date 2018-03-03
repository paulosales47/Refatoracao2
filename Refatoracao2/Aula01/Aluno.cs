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

        public Aluno()
        {
            _cursos = new List<string>();
        }

        public void AdicionaCurso(string curso)
        {
            if (string.IsNullOrEmpty(curso))
            {
                throw new ArgumentException("O nome do curso não pode ser nulo ou vazio");
            }
            else
            {
                _cursos.Add(curso);
            }
        }

        public void RemoveCurso(string curso)
        {
            if (string.IsNullOrEmpty(curso))
            {
                throw new ArgumentException("O nome do curso não pode ser nulo ou vazio");
            }
            else
            {
                _cursos.Remove(curso);
            }

        }


    }
}
