/* General Styles */
body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
  line-height: 1.6;
  color: #333;
}

.container {
  width: 90%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 20px 0;
}

h1, h2, h3 {
  margin: 0;
  padding: 0;
}

a {
  text-decoration: none;
  color: inherit;
}

/* Navbar Styles */
#navbar {
  background: #333;
  color: #fff;
  padding: 10px 0;
  position: sticky;
  top: 0;
  z-index: 1000;
}

#navbar .logo {
  float: left;
  font-size: 24px;
}

#navbar ul {
  float: right;
  list-style: none;
  margin: 0;
  padding: 0;
}

#navbar ul li {
  display: inline;
  margin-left: 20px;
}

#navbar ul li a {
  color: #fff;
  font-size: 18px;
}

#navbar ul li a:hover {
  color: #f4c10f;
}

/* Section Styles */
.section {
  padding: 60px 0;
}

.section h2 {
  text-align: center;
  margin-bottom: 40px;
  font-size: 32px;
}

/* About Section */
.about-content {
  display: flex;
  align-items: center;
  gap: 20px;
}

.profile-photo {
  width: 150px;
  height: 150px;
  border-radius: 50%;
  object-fit: cover;
}

.about-text {
  flex: 1;
}

/* Skills Section */
.skills-content {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

.skill-category {
  flex: 1 1 calc(33.333% - 20px);
  background: #f4f4f4;
  padding: 20px;
  border-radius: 5px;
  text-align: center;
}

/* Courses and Certifications Sections */
.courses-content, .certifications-content {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

.course, .certification {
  flex: 1 1 calc(50% - 20px);
  background: #f4f4f4;
  padding: 20px;
  border-radius: 5px;
}

/* Projects Section */
.projects-content {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

.project {
  flex: 1 1 calc(50% - 20px);
  background: #f4f4f4;
  padding: 20px;
  border-radius: 5px;
}

/* Contact Section */
.contact-content {
  display: flex;
  justify-content: center;
  gap: 20px;
}

.contact-content img {
  width: 40px;
  height: 40px;
  transition: transform 0.3s ease;
}

.contact-content img:hover {
  transform: scale(1.2);
}

/* Footer Styles */
footer {
  background: #333;
  color: #fff;
  text-align: center;
  padding: 10px 0;
  margin-top: 40px;
}
