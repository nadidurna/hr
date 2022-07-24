<template>
  <div id="wrapper">
    <!-- Sidebar -->
    <ul
      class="navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"
      id="accordionSidebar"
    >
      <!-- Sidebar - Brand -->
      <a
        class="sidebar-brand d-flex align-items-center justify-content-center"
        href="/"
      >
        <div class="sidebar-brand-text">
          <img src="../assets/circle_logo.svg" alt="" />
        </div>
      </a>

      <!-- Divider -->
      <hr class="sidebar-divider my-0" />

      <!-- Nav Item - Dashboard -->
      <li class="nav-item active">
        <a class="nav-link" href="/"> <span>Home</span></a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="/login"> <span>Login</span></a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="/register"> <span>Register</span></a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="/companies"> <span>Şirketler</span></a>
      </li>

      <!-- Divider -->
      <hr class="sidebar-divider" />

      <!-- Heading -->
      <div class="sidebar-heading">Pages</div>

      <!-- Nav Item - Pages Collapse Menu -->
      <li class="nav-item">
        <a
          class="nav-link collapsed"
          href="#"
          data-toggle="collapse"
          data-target="#collapseTwo"
          aria-expanded="true"
          aria-controls="collapseTwo"
        >
          <i class="fas fa-fw fa-cog"></i>
          <span>Components</span>
        </a>
        <div
          id="collapseTwo"
          class="collapse"
          aria-labelledby="headingTwo"
          data-parent="#accordionSidebar"
        >
          <div class="bg-white py-2 collapse-inner rounded">
            <h6 class="collapse-header">Custom Components:</h6>
            <a class="collapse-item" href="buttons.html">Buttons</a>
            <a class="collapse-item" href="cards.html">Cards</a>
          </div>
        </div>
      </li>

      <!-- Nav Item - Utilities Collapse Menu -->
      <li class="nav-item">
        <a
          class="nav-link collapsed"
          href="#"
          data-toggle="collapse"
          data-target="#collapseUtilities"
          aria-expanded="true"
          aria-controls="collapseUtilities"
        >
          <i class="fas fa-fw fa-wrench"></i>
          <span>Utilities</span>
        </a>
        <div
          id="collapseUtilities"
          class="collapse"
          aria-labelledby="headingUtilities"
          data-parent="#accordionSidebar"
        >
          <div class="bg-white py-2 collapse-inner rounded"></div>
        </div>
      </li>
      <li class="nav-item">
        <a
          class="nav-link collapsed"
          href="#"
          data-toggle="collapse"
          data-target="#collapseCalendar"
          aria-expanded="true"
          aria-controls="collapseCalendar"
        >
          <i class="fas fa-fw fa-wrench"></i>
          <span>Calendar</span>
        </a>
        <div
          id="collapseCalendar"
          class="collapse"
          aria-labelledby="headingCalendar"
          data-parent="#accordionSidebar"
        ></div>
      </li>

      <!-- Divider -->
      <hr class="sidebar-divider d-none d-md-block" />
    </ul>

    <div id="content-wrapper" class="d-flex flex-column"></div>
  </div>
</template>

<style>
.wrapper {
  position: fixed;
}
</style>
