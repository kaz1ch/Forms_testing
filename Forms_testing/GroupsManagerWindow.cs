using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Forms_testing.Models;

namespace Forms_testing
{
    public partial class GroupsManagerWindow : Form
    {
        private readonly List<Group> _Groups;
        private readonly List<Student> _Students;

        public GroupsManagerWindow(List<Group> Groups, List<Student> Students)
        {
            _Groups = Groups;
            _Students = Students;

            InitializeComponent();

            foreach (var group in Groups)
                GroupsList.Items.Add(group.Name);
        }

        private void GroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_index = GroupsList.SelectedIndex;
            if (selected_index < 0) return;

            var group = _Groups[selected_index];

            GroupNameEdit.Text = group.Name;
            GroupCourseEdit.Value = group.Course;
            GroupDescriptionEdit.Text = group.Description;

            GroupStudentsListBox.Items.Clear();
            foreach (var student in _Students.Where(s => s.GroupId == group.Id))
                GroupStudentsListBox.Items.Add($"{student.LastName} {student.Name}");
        }
    }
}
