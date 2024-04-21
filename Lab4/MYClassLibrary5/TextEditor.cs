using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Клас, що відповідає за збереження та відновлення стану документу
    public class TextEditor
    {
        private TextDocument _document;
        private Memento _savedState; // Збережений стан документу

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        // Зберігання поточного стану документу
        public Memento Save()
        {
            _savedState = new Memento(_document.Content);
            return _savedState;
        }

        // Відновлення стану документу збереженого моменту часу
        public void Restore()
        {
            _document.Content = _savedState.Content;
        }

        // Перевіряє, чи є доступний стан для відновлення
        public bool CanRestore()
        {
            return _savedState != null;
        }

        // Повертає поточний стан документу
        public string GetCurrentState()
        {
            return _document.Content;
        }
    }
}
