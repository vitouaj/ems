<template>
  <div class="center-container">
    <emsCard :class="mode === 'login' ? 'Card-login' : 'Card-signup'">
      <h1 class="title">
        <span class="Event">Event</span>
        <span class="Hub">hub</span>
      </h1>
      <template v-if="mode === 'login'">
        <div class="center">
          <span>We are thrilled to have you back.</span>
        </div>
        <form @submit.prevent="login">
          <div class="form-group">
            <emsTextfield
              id="email"
              label="Email"
              v-model="loginData.email"
              type="email"
              required
              class="TextField input"
            />
          </div>
          <div class="form-group">
            <emsTextfield
              id="password"
              label="Password"
              v-model="loginData.password"
              type="password"
              required
            />
          </div>
          <div class="form-group">
            <emsTextfield
              id="phoneNumber"
              label="Phone Number"
              v-model="signupData.phoneNumber"
              type="tel"
              required
            />
          </div>
          <div class="forgot-remember-container">
            <a href="#" class="forgot-password">Forget your password</a>
            <div class="checkbox">
              <input type="checkbox" id="rememberMe" v-model="rememberMe" />
              <label for="rememberMe">Remember me</label>
            </div>
          </div>
          <emsBtn type="submit" class="ButtonCard">Log In as an admin</emsBtn>
        </form>
        <p class="center">
          Don't have an account? <a href="#" @click="toggleMode">Register</a>
        </p>
      </template>
      <template v-else>
        <div class="center">
          <span>Register a new account</span>
        </div>
        <div v-col="6">
          <form @submit.prevent="signup" class="signup-form">
            <div class="form-column">
              <div class="form-group">
                <emsTextfield
                  id="name"
                  label="Full Name"
                  v-model="signupData.name"
                  required
                />
              </div>
              <div class="form-group">
                <emsTextfield
                  id="email"
                  label="Email"
                  v-model="signupData.email"
                  type="email"
                  required
                />
              </div>
              <div class="form-group">
                <emsTextfield
                  id="password"
                  label="Password"
                  v-model="signupData.password"
                  :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                  @click:append="showPassword = !showPassword"
                  :type="showPassword ? 'text' : 'password'"
                  required
                />
              </div>
              <div class="form-group">
                <emsTextfield
                  id="confirm-password"
                  label="Confirm Password"
                  v-model="signupData.password"
                  :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
                  @click:append="showPassword = !showPassword"
                  :type="showPassword ? 'text' : 'password'"
                  required
                />
              </div>
              <div class="checkbox">
                <input type="checkbox" id="register" v-model="register" />
                <label for="register">Register an event organizer</label>
              </div>
              <div class="checkbox">
                <input type="checkbox" id="terms" v-model="terms" />
                <label for="terms"
                  >I agree to the term <a href="#" style="bold">Eventhub</a></label
                >
              </div>
            </div>
            <div class="form-column">
              <div class="profile-upload">
                <emsFileUpload :onFileChange="handleProfilePictureChange" />
              </div>
              <emsTextfield
                id="orgName"
                label="Organization Name"
                v-model="signupData.orgName"
                required
              />
              <emsTextfield
                id="lineBusiness"
                label="Line of Business"
                v-model="signupData.lineBusiness"
                required
              />
            </div>
          </form>
          <emsBtn type="submit" class="ButtonCard">Sign Up</emsBtn>
        </div>
        <div class="center">
          <span
            >Already have an account? <a href="#" @click="toggleMode">Log In </a></span
          >
        </div>
      </template>
    </emsCard>
  </div>
</template>

<script setup lang="ts">
import { ref, watch } from "vue";
import { useRouter } from "vue-router";
import emsFileUpload from "../../components/emsFileUpload.vue";
import emsCard from "./../../components/emsCard.vue";
import emsBtn from "./../../components/emsBtn.vue";
import emsTextfield from "./../../components/emsTextfield.vue";
const router = useRouter();

const mode = ref("login");
const loginData = ref({
  email: "",
  password: "",
});
const signupData = ref({
  name: "",
  email: "",
  phoneNumber: "+855",
  password: "",
  orgName: "",
  lineBusiness: "",
  profilePicture: null as File | null,
});
const rememberMe = ref(false);
const register = ref(false);
const terms = ref(false);
const showPassword = ref(false);

const login = () => {};

const signup = () => {};
const handleProfilePictureChange = (file: File) => {
  signupData.value.profilePicture = file;
};

const toggleMode = () => {
  mode.value = mode.value === "login" ? "signup" : "login";
};

watch(
  mode,
  (newValue) => {
    router.replace({ name: "authAdmin", params: { mode: newValue } });
  },
  { immediate: true }
);
</script>

<style scoped>
.center-container {
  background-image: url("@/assets/background.jpg");
  display: flex;
  align-items: center;
  height: 100vh;
  justify-content: center;
}

.Card {
  border-radius: 30px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  padding: 30px;
  margin: 20px auto;
  width: 30%;
  color: #004b8d;
}

.Card-login {
  width: 30%;
  border-radius: 30px;
}

.Card-signup {
  width: 50%;
  border-radius: 30px;
}

.form-row {
  display: flex;
  justify-content: space-between;
  margin-bottom: 15px;
}

.form-group {
  flex: 1;
  margin-right: 15px;
}

.TextField label {
  font-weight: bold;
}

.TextField input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 10px;
}

.ButtonCard {
  background-color: #6f6fdcd0;
  color: white;
  border: none;
  border-radius: 50px;
  margin-bottom: 10px;
  padding: 10px 20px;
  cursor: pointer;
  transition: background-color 0.3s ease;
  margin-top: 10px;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 50%;
}

.ButtonCard:hover {
  background-color: #ffa500;
}

.forgot-password {
  display: block;
  margin-top: 10px;
  color: #004b8d;
  text-decoration: none;
  font-weight: bold;
}

.forgot-password:hover {
  text-decoration: underline;
}

.Event {
  color: #004b8d;
}

.Hub {
  color: #ffa500;
}

.title {
  text-align: center;
  font-weight: bold;
  font-style: italic;
}

.center {
  text-align: center;
  font-size: 18px;
}

.forgot-remember-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 5px;
}

.checkbox {
  display: flex;
  align-items: center;
  color: #004b8d;
  font-size: 15px;
}

.signup-form {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-column-gap: 20px;
}

.form-column {
  display: flex;
  flex-direction: column;
  margin: 20px 20px;
}
.profile-upload {
  margin-bottom: 10px;
}
</style>
